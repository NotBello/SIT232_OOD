//Created by Venujan Malaiyandi (A.k.a) Bello
// BSCP|CS|61|101
// For Task 5.3D
//Tester

using System;
using System.Data;


namespace SimpleReactionMachine
{
    public class SimpleReactionController : IController
    {
        // Settings for the game times
        private const int MIN_TIME = 100; 
        private const int MAX_TIME = 250; 
        private const int MAXG_TIME = 200; 
        private const int GMOVER_TIME = 300; 
        private const double TPS = 100.0; 

        // Instance variables and properties
        private State _state;
        private IGui Gui { get; set; }
        private IRandom Rng { get; set; }
        private int Ticks { get; set; }  // counter each time controller.Tick() is called 

        
        public void Connect(IGui gui, IRandom rng)
        {
            Gui = gui;
            Rng = rng;
            Init();
        }

        public void Init()
        {
            _state = new OnState(this);
        }
                
        public void CoinInserted()
        {
            _state.CoinInserted();
        }

        public void GoStopPressed()
        {
            _state.GoStopPressed();
        }


        public void Tick()
        {
            _state.Tick();
        }

        private void SetState(State state)
        {
            _state = state;
        }

        private abstract class State
        {
            protected SimpleReactionController _controller;

            public State(SimpleReactionController controller)
            {
                _controller = controller;
            }

            public abstract void CoinInserted();
            public abstract void GoStopPressed();
            public abstract void Tick();
        }

        private class OnState : State
        {
            public OnState(SimpleReactionController controller) : base(controller)
            {
                _controller.Gui.SetDisplay("Insert coin");
            }

            public override void CoinInserted()
            {
                _controller.SetState(new ReadyState(_controller));
            }
            public override void GoStopPressed() { }
            public override void Tick() { }
        }

        private class ReadyState : State
        {
            public ReadyState(SimpleReactionController controller) : base(controller)
            {
                _controller.Gui.SetDisplay("Press Go!");
            }

            public override void CoinInserted() { }
            public override void GoStopPressed()
            {
                _controller.SetState(new WaitState(_controller));
            }
            public override void Tick() { }
        }

        private class WaitState : State
        {
            private int _waitTime;
            public WaitState(SimpleReactionController controller) : base(controller)
            {
                _controller.Gui.SetDisplay("Wait...");
                _controller.Ticks = 0;
                _waitTime = _controller.Rng.GetRandom(MIN_TIME, MAX_TIME);
            }

            public override void CoinInserted() { }
            public override void GoStopPressed()
            {
                _controller.SetState(new OnState(_controller));
            }
            public override void Tick()
            {
                _controller.Ticks++;
                if (_controller.Ticks == _waitTime)
                {
                    _controller.SetState(new RunningState(_controller));
                }
            }
        }

        private class RunningState : State
        {
            public RunningState(SimpleReactionController controller) : base(controller)
            {
                _controller.Gui.SetDisplay("0.00");
                _controller.Ticks = 0;
            }

            public override void CoinInserted() { }
            public override void GoStopPressed()
            {
                _controller.SetState(new GameOverState(_controller));
            }

            public override void Tick()
            {
                _controller.Ticks++;
                _controller.Gui.SetDisplay(
                    (_controller.Ticks / TPS).ToString("0.00"));
                if (_controller.Ticks == MAXG_TIME)
                {
                    _controller.SetState(new GameOverState(_controller));
                }
            }
        }

        /// <summary>
        /// State of the game when the time has expired, or the user reacted.
        /// </summary>
        private class GameOverState : State
        {
            public GameOverState(SimpleReactionController controller) : base(controller)
            {
                _controller.Ticks = 0;
            }

            public override void CoinInserted() { }
            public override void GoStopPressed()
            {
                _controller.SetState(new OnState(_controller));
            }
            public override void Tick()
            {
                _controller.Ticks++;
                if (_controller.Ticks == GMOVER_TIME)
                {
                    _controller.SetState(new OnState(_controller));
                }
            }
        }
    }
}
