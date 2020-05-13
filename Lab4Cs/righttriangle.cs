using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab4Cs
{
    class RightTriangle : Triangle
    {
        public RightTriangle()
        {

        }

        public bool isRight()
        {
            bool result = false;

            for (int i = 0; i < 3; i++)
            {
                if (lenght[i] * lenght[i] + lenght[(i + 1) % 3] * lenght[(i + 1) % 3] == lenght[(i + 2) % 3] * lenght[(i + 2) % 3])
                {
                    result = true;
                }
            }
            return result;
        }
        public RightTriangle Read(BinaryReader br)
        {
            RightTriangle all = new RightTriangle();

            for (int i = 0; i < points.Length; i++)
            {
                all.points[i].x = br.ReadInt32();
                all.points[i].y = br.ReadInt32();
            }
            for (int i = 0; i < 3; i++)
            {
                all.lenght[i] = br.ReadDouble();
            }
            all.angle1 = br.ReadDouble();
            all.angle2 = br.ReadDouble();
            all.angle3 = br.ReadDouble();
            all.perimetr = br.ReadDouble();
            all.square = br.ReadDouble();

            return all;
        }



    }
}
