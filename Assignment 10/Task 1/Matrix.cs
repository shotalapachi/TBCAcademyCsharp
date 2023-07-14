using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Matrix
    {
        public int[,] ints = new int[2, 2];

        public static explicit operator int(Matrix matrix)
        {
            int result = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result += matrix.ints[i, j];
                }
            }
            return result;
        }
        public static explicit operator double(Matrix matrix)
        {
            double result = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result += matrix.ints[i, j];
                }
            }
            return result;
        }
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            Matrix result = new Matrix();
            result.ints = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result.ints[i, j] = matrix1.ints[i, j] + matrix2.ints[i, j];
                }
            }
            return result;
        }
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            Matrix result = new Matrix();
            result.ints = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result.ints[i, j] = matrix1.ints[i, j] - matrix2.ints[i, j];
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            Matrix result = new Matrix();
            result.ints = new int[2, 2];

            result.ints[0, 0] = matrix1.ints[0, 0] * matrix2.ints[0, 0] + matrix1.ints[0, 1] * matrix2.ints[1, 0];
            result.ints[0, 1] = matrix1.ints[0, 0] * matrix2.ints[0, 1] + matrix1.ints[0, 1] * matrix2.ints[1, 1];
            result.ints[1, 0] = matrix1.ints[1, 0] * matrix2.ints[0, 0] + matrix1.ints[1, 1] * matrix2.ints[1, 0];
            result.ints[1, 1] = matrix1.ints[1, 0] * matrix2.ints[0, 1] + matrix1.ints[1, 1] * matrix2.ints[1, 1];

            return result;
        }

        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.ints[0, 0] == matrix2.ints[0, 0]
                && matrix1.ints[0, 1] == matrix2.ints[0, 1]
                && matrix1.ints[1, 0] == matrix2.ints[1, 0]
                && matrix1.ints[1, 1] == matrix2.ints[1, 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.ints[0,1] != matrix2.ints[0,1]
                || matrix1.ints[0, 0] != matrix2.ints[0, 0]
                || matrix1.ints[1, 0] != matrix2.ints[1, 0]
                || matrix1.ints[1, 1] != matrix2.ints[1, 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Matrix operator -(Matrix matrix)
        {
            Matrix result = new Matrix();
            Matrix temp = matrix;

            int det = temp.ints[0, 0] * temp.ints[1, 1] - temp.ints[0, 1] * temp.ints[1, 0];

            result.ints[0, 0] = temp.ints[1, 1] * det;
            result.ints[0, 1] = temp.ints[0, 1] * temp.ints[1, 0] / temp.ints[1, 0] * det;
            result.ints[1, 0] = temp.ints[1, 0] * temp.ints[0, 1] / temp.ints[0, 1] * det;
            result.ints[1, 1] = temp.ints[0, 0] * det;

            return result;
        }

        public static void PrintMatrix(Matrix matrix)
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{matrix.ints[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return $"0 0: {this.ints[0,0]} 0 1: {this.ints[0,1]} 1 0: {this.ints[1, 0]} 1 1: {this.ints[1, 1]}";
        }

        public override bool Equals(object obj1)
        {
            if (this == (Matrix)obj1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

