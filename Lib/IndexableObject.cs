using System;

namespace Lib
{
    public class IndexableObject
    {
        private float I0 { get; set; }
        private float I1 { get; set; }


        public float this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return I0;
                }
                else if (index == 1)
                {
                    return I1;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index == 0)
                {
                    I0 = value;
                }
                else if (index == 1)
                {
                    I1 = value;
                    I0 = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
