using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares
{
    public interface Subscribers
    {
        public void Update();
    }
    public class Counter : Subscribers
    {
        private int counter;
        public void Update()
        {
            counter++;
        }

        public int getCounter() { return counter; }
    }
}
