namespace Felli
{
    public class Board
    {

        private State[][] states;
        private int turn;
        private int countB;
        private int countW;

        private State NextTurn
        {
            get
            {
                if (Finished)
                {
                    return State.Undecided;
                }
                else if (turn % 2 == 0)
                {
                    return State.B;
                }
                else
                {
                    return State.W;
                }
            }
        }

        public bool Finished
        {
            get
            {
            for (int i = 0; i < states.Length; i++)
            {
                for (int j = 0; j < states[i].Length; j++)
                {
                    if (states[i][j] == State.B){
                        countB++;
                    }
                    if (states[i][j] == State.W){
                        countW++;
                    }
                }
            }

            if(countB>0 && countW>0){
                return false;
            }

            return true;
            }
        }

        public Board()
        {
            states = new State[5][];
            states[0] = new State[2];
            states[1] = new State[2];
            states[2] = new State[0];
            states[3] = new State[2];
            states[4] = new State[2];
            countB = 0;
            countW = 0;
        
            for (int i = 0; i< 2;i++){

                for (int j = 0; j < states[i].Length; j++)
                {
                    states[i][j] = State.B;
                }
            }
            for (int i = 3; i< 5;i++){

                for (int j = 0; j < states[i].Length; j++)
                {
                    states[i][j] = State.W;
                }
            }
        }
    }
}