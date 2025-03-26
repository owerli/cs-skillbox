﻿using System;

namespace GameOfLife
{

    public class LifeSimulation
    {
        private int _heigth;
        private int _width;
        private bool[,] cells;
        private Random rand = new Random();

        /// <summary>
        /// Создаем новую игру
        /// </summary>
        /// <param name="Heigth">Высота поля.</param>
        /// <param name="Width">Ширина поля.</param>
        public LifeSimulation(int Heigth, int Width)
        {
            _heigth = Heigth;
            _width = Width;
            cells = new bool[Heigth, Width];
            GenerateField();
        }

        /// <summary>
        /// Перейти к следующему поколению и вывести результат на консоль.
        /// </summary>
        public void DrawAndGrow()
        {
            DrawGame();
            Grow();
        }


        /// <summary>
        /// Проверить наличие соседей и определить появится, останется или умрет бактерия в клетке
        /// <param name="i">Индекс строки клетки.</param>
        /// <param name="j">Индекс столбца клетки.</param>
        /// </summary>
        private void SetLifeOrDie(int i, int j) {

            int numOfAliveNeighbors = GetNeighbors(i, j);

            if (cells[i, j])
            {

                if (numOfAliveNeighbors < 1)
                {
                    cells[i, j] = false;
                }

                if (numOfAliveNeighbors > 1)
                {
                    cells[i, j] = false;
                }

            }
            else
            {

                if (numOfAliveNeighbors < 2)
                {
                    cells[i, j] = true;
                }

            }

        }


        /// <summary>
        /// Двигаем состояние на одно вперед, по установленным правилам
        /// </summary>
        private void Grow()
        {

            int isReverse = rand.Next(2);

            if (isReverse == 0)
            {

                for (int i = 0; i < _heigth; i++)
                {

                    for (int j = 0; j < _width; j++)
                    {

                        SetLifeOrDie(i, j);

                    }

                }

            }
            else 
            {

                for (int i = _heigth - 1; i >= 0; i--)
                {

                    for (int j = _width - 1; j >= 0 ; j--)
                    {

                        SetLifeOrDie(i, j);

                    }

                }

            }

        }

        /// <summary>
        /// Смотрим сколько живых соседий вокруг клетки.
        /// </summary>
        /// <param name="x">X-координата клетки.</param>
        /// <param name="y">Y-координата клетки.</param>
        /// <returns>Число живых клеток.</returns>
        private int GetNeighbors(int x, int y)
        {
            int NumOfAliveNeighbors = 0;

            for (int i = x - 1; i < x + 2; i++)
            {

                for (int j = y - 1; j < y + 2; j++)
                {

                    if (!((i < 0 || j < 0) || (i >= _heigth || j >= _width)))
                    {

                        if (cells[i, j] == true) NumOfAliveNeighbors++;
                    
                    }

                }

            }

            return NumOfAliveNeighbors;

        }

        /// <summary>
        /// Нарисовать Игру в консоле
        /// </summary>
        private void DrawGame()
        {

            for (int i = 0; i < _heigth; i++)
            {

                for (int j = 0; j < _width; j++)
                {

                    Console.Write(cells[i, j] ? "x" : " ");
                    if (j == _width - 1) Console.WriteLine("\r");

                }

            }

            Console.SetCursorPosition(0, Console.WindowTop);

        }

        /// <summary>
        /// Инициализируем случайными значениями
        /// </summary>
        private void GenerateField()
        {

            Random generator = new Random();
            int number;

            for (int i = 0; i < _heigth; i++)
            {

                for (int j = 0; j < _width; j++)
                {

                    number = generator.Next(2);
                    cells[i, j] = ((number == 0) ? false : true);

                }

            }

        }

    }

    internal class Program
    {

        // Ограничения игры
        private const int Heigth = 10;
        private const int Width = 30;
        private const uint MaxRuns = 100;

        private static void Main(string[] args)
        {

            int runs = 0;
            LifeSimulation sim = new LifeSimulation(Heigth, Width);

            while (runs++ < MaxRuns)
            {

                sim.DrawAndGrow();

                // Дадим пользователю шанс увидеть, что происходит, немного ждем
                System.Threading.Thread.Sleep(250);

            }

        }

    }

}
