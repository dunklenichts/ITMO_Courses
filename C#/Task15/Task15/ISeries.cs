using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void Reset();
    }

    class ArithProgression : ISeries
    {
        int start;
        int current;
        int step;

        public int getNext()
        {
            current += step;

            return current;
        }

        public void Reset()
        {
            current = start;
        }

        public void setStart(int x)
        {
            start = x;
            current = start;
        }

        public void setStep(int s) 
        {
            step = s;
        }
    }

    class GeomProgression : ISeries
    {
        int start;
        int current;
        int step;

        public int getNext()
        {
            int nextValue = current;
            current *= step;

            return nextValue;
        }

        public void Reset()
        {
            current = start;
        }

        public void setStart(int x)
        {
            start = x;
            current = x;
        }

        public void setStep(int s)
        {
            step = s;
        }
    }
}
