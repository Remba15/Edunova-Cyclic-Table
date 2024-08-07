using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edunova_Cyclic_Table
{
    internal class CyclicTable
    {
        internal static void Execute()
        {
            bool loop = true;
            while (loop)
            {
                try
                {
                    Console.WriteLine("Insert a number to choose starting position:");
                    Console.WriteLine("\t1 - Bottom right\n\t2 - Bottom left\n\t3 - Top left\n\t4 - Top right");

                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            BottomRight();
                            loop = false;
                            break;
                        case 2:
                            BottomLeft();
                            loop = false;
                            break;
                        case 3:
                            TopLeft();
                            loop = false;
                            break;
                        case 4:
                            TopRight();
                            loop = false;
                            break;
                        default:
                            Console.WriteLine("Wrong input, try again!\n");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Wrong input! Insert whole numbers only!\n");
                }
            }
        }

        #region Position
        private static void BottomRight()
        {
            bool loop = true;
            while (loop)
            {
                try
                {
                    int choice;

                    Console.WriteLine("\nChoose rotation:");
                    Console.WriteLine("\n\t1 - Clockwise\n\t2 - Anti-clockwise");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            ClockwiseBottomRight();
                            loop = false;
                            break;
                        case 2:
                            AnticlockwiseBottomRight();
                            loop = false;
                            break;
                        default:
                            Console.WriteLine("Wrong input! Choose again.");
                            break;
                    }
                    break;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong input!" + e.Message);
                }
            }
        }

        private static void BottomLeft()
        {
            bool loop = true;
            while (loop)
            {
                try
                {
                    int choice;

                    Console.WriteLine("\nChoose rotation:");
                    Console.WriteLine("\n\t1 - Clockwise\n\t2 - Anti-clockwise");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            ClockwiseBottomLeft();
                            loop = false;
                            break;
                        case 2:
                            AnticlockwiseBottomLeft();
                            loop = false;
                            break;
                        default:
                            Console.WriteLine("Wrong input! Choose again.");
                            break;
                    }
                    break;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong input!" + e.Message);
                }
            }
        }

        

        private static void TopLeft()
        {
            bool loop = true;
            while (loop)
            {
                try
                {
                    int choice;

                    Console.WriteLine("\nChoose rotation:");
                    Console.WriteLine("\n\t1 - Clockwise\n\t2 - Anti-clockwise");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            ClockwiseTopLeft();
                            loop = false;
                            break;
                        case 2:
                            AnticlockwiseTopLeft();
                            loop = false;
                            break;
                        default:
                            Console.WriteLine("Wrong input! Choose again.");
                            break;
                    }
                    break;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong input!" + e.Message);
                }
            }
        }

        

        private static void TopRight()
        {
            bool loop = true;
            while (loop)
            {
                try
                {
                    int choice;

                    Console.WriteLine("\nChoose rotation:");
                    Console.WriteLine("\n\t1 - Clockwise\n\t2 - Anti-clockwise");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            ClockwiseTopRight();
                            loop = false;
                            break;
                        case 2:
                            AnticlockwiseTopRight();
                            loop = false;
                            break;
                        default:
                            Console.WriteLine("Wrong input! Choose again.");
                            break;
                    }
                    break;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong input!" + e.Message);
                }
            }
        }

        
        #endregion


        #region Rotation
        private static void ClockwiseBottomRight()
        {
            bool loop = true;
            while (loop)
            {
                try
                {
                    int choice;


                    Console.WriteLine("Insert a number of rows.");
                    int rowNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("Insert a number of columns.");
                    int columnNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("Choose order:");
                    Console.WriteLine("\n\t1 - Ascending\n\t2 - Descending");
                    choice = int.Parse(Console.ReadLine());

                    int[,] table = new int[rowNumber, columnNumber];


                    if (choice == 1)
                    {
                        loop = false;
                        int product = rowNumber * columnNumber;

                        int step = 1;
                        int fallingRow = rowNumber - 1,
                            risingRow = 0,
                            fallingColumn = columnNumber - 1,
                            risingColumn = 0;



                        while (step <= product)
                        {
                            for (int j = fallingColumn; j >= risingColumn; j--)
                            {
                                if (step <= product)
                                {
                                    table[fallingRow, j] = step++;
                                }

                            }
                            --fallingRow;


                            for (int i = fallingRow; i >= risingRow; i--)
                            {
                                if (step <= product)
                                {
                                    table[i, risingColumn] = step++;
                                }
                            }
                            ++risingColumn;


                            for (int j = risingColumn; j <= fallingColumn; j++)
                            {
                                if (step <= product)
                                {
                                    table[risingRow, j] = step++;
                                }
                            }
                            ++risingRow;


                            for (int i = risingRow; i <= fallingRow; i++)
                            {
                                if (step <= product)
                                {
                                    table[i, fallingColumn] = step++;
                                }
                            }
                            --fallingColumn;
                        }
                        PrintTable(table);
                    }
                    else if(choice == 2)
                    {
                        loop = false;
                        int product = rowNumber * columnNumber;

                        int fallingRow = rowNumber - 1,
                            risingRow = 0,
                            fallingColumn = columnNumber - 1,
                            risingColumn = 0;

                        while (product > 0)
                        {
                            for (int j = fallingColumn; j >= risingColumn; j--)
                            {
                                if (product > 0)
                                {
                                    table[fallingRow, j] = product--;
                                }

                            }
                            --fallingRow;


                            for (int i = fallingRow; i >= risingRow; i--)
                            {
                                if (product > 0)
                                {
                                    table[i, risingColumn] = product--;
                                }
                            }
                            ++risingColumn;


                            for (int j = risingColumn; j <= fallingColumn; j++)
                            {
                                if (product > 0)
                                {
                                    table[risingRow, j] = product--;
                                }
                            }
                            ++risingRow;


                            for (int i = risingRow; i <= fallingRow; i++)
                            {
                                if (product > 0)
                                {
                                    table[i, fallingColumn] = product--;
                                }
                            }
                            --fallingColumn;
                        }
                        PrintTable(table);
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice input!\n");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong input! " + e.Message);
                }
            }
        }

        private static void AnticlockwiseBottomRight()
        {
            bool loop = true;
            while (loop)
            {
                try
                {
                    int choice;


                    Console.WriteLine("\nInsert a number of rows.");
                    int rowNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nInsert a number of columns.");
                    int columnNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("Choose order:");
                    Console.WriteLine("\n\t1 - Ascending\n\t2 - Descending");
                    choice = int.Parse(Console.ReadLine());

                    int[,] table = new int[rowNumber, columnNumber];


                    if (choice == 1)
                    {
                        loop = false;
                        int product = rowNumber * columnNumber;

                        int step = 1;
                        int fallingRow = rowNumber - 1,
                            risingRow = 0,
                            fallingColumn = columnNumber - 1,
                            risingColumn = 0;



                        while (step <= product)
                        {
                            for(int i = fallingRow; i >= risingRow; i--)
                            {
                                if(step <= product)
                                {
                                    table[i, fallingColumn] = step++;
                                }
                            }
                            --fallingColumn;

                            for(int j = fallingColumn; j >= risingColumn; j--)
                            {
                                if(step <= product)
                                {
                                    table[risingRow, j] = step++;
                                }
                            }
                            ++risingRow;

                            for(int i = risingRow; i <= fallingRow; i++)
                            {
                                if(step <= product)
                                {
                                    table[i, risingColumn] = step++;
                                }
                            }
                            ++risingColumn;

                            for(int j = risingColumn; j <= fallingColumn; j++)
                            {
                                if(step <= product)
                                {
                                    table[fallingRow, j] = step++;
                                }
                            }
                            --fallingRow;
                        }
                        PrintTable(table);
                    }
                    else if (choice == 2)
                    {
                        loop = false;
                        int product = rowNumber * columnNumber;


                        int fallingRow = rowNumber - 1,
                            risingRow = 0,
                            fallingColumn = columnNumber - 1,
                            risingColumn = 0;


                        while (product > 0)
                        {
                            for (int i = fallingRow; i >= risingRow; i--)
                            {
                                if (product > 0)
                                {
                                    table[i, fallingColumn] = product--;
                                }
                            }
                            --fallingColumn;

                            for (int j = fallingColumn; j >= risingColumn; j--)
                            {
                                if (product > 0)
                                {
                                    table[risingRow, j] = product--;
                                }
                            }
                            ++risingRow;

                            for (int i = risingRow; i <= fallingRow; i++)
                            {
                                if (product > 0)
                                {
                                    table[i, risingColumn] = product--;
                                }
                            }
                            ++risingColumn;

                            for (int j = risingColumn; j <= fallingColumn; j++)
                            {
                                if (product > 0)
                                {
                                    table[fallingRow, j] = product--;
                                }
                            }
                            --fallingRow;
                        }
                        PrintTable(table);
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice input!\n");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong input! " + e.Message);
                }
            }
        }


        private static void ClockwiseBottomLeft()
        {
            throw new NotImplementedException();
        }

        private static void AnticlockwiseBottomLeft()
        {
            throw new NotImplementedException();
        }


        private static void ClockwiseTopLeft()
        {
            throw new NotImplementedException();
        }

        private static void AnticlockwiseTopLeft()
        {
            throw new NotImplementedException();
        }


        private static void ClockwiseTopRight()
        {
            throw new NotImplementedException();
        }

        private static void AnticlockwiseTopRight()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Printing
        public static void PrintTable(int[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0, 10}", table[i, j] + " "));
                }
                Console.WriteLine();
            }
        }
        #endregion
    }
}
