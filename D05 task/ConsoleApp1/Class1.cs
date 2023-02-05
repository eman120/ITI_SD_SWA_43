using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Point3D
    {
        int x;
        int y;
        int z;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }

        public Point3D()
        {
            int input;
            do
            {
                Console.Write("X : ");
            } while (!int.TryParse(Console.ReadLine(), out input));
            X = input;

            do
            {
                Console.Write("Y : ");
            } while (!int.TryParse(Console.ReadLine(), out input));
            Y = input;

            do
            {
                Console.Write("Z : ");
            } while (!int.TryParse(Console.ReadLine(), out input));
            Z = input;
        }

        public Point3D(int x, int y , int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public static explicit operator string(Point3D P)
        {
            return P.ToString();
        }
        //public static bool operator ==(Point3D Left, Point3D Right)
        //{
        //    if ((Left != null) && (Right != null))
        //        return (Left.X == Right.X) && (Left.Y == Right.Y) && (Left.Z == Right.Z);
        //    return false;
        //}

        //public static bool operator !=(Point3D Left, Point3D Right)
        //{
        //    throw new NotImplementedException();
        //}

        public override bool Equals(object? obj)
        {
            Point3D? p = (Point3D?)obj;
            return p != null && (X == p.X) && (Y == p.Y) && (Z == p.Z);
        }
    }
}

