﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _3PS
{
    class Board
    {
        private Field[] field;
        public Board()
        {
            this.field = new Field[9];
            for (int i = 0; i < 9; i++)
            {
                Field fields = new Field(Convert.ToChar(i));
                field[i] = fields;
            }
        }

        public void DrawBoard()
        {
            Console.WriteLine("| 0(" + field[0].GetPieceToken() + ") | 1(" + field[1].GetPieceToken() + ") | 2(" + field[2].GetPieceToken() + ") |");
            Console.WriteLine("| 3(" + field[3].GetPieceToken() + ") | 4(" + field[4].GetPieceToken() + ") | 5(" + field[5].GetPieceToken() + ") |");
            Console.WriteLine("| 6(" + field[6].GetPieceToken() + ") | 7(" + field[7].GetPieceToken() + ") | 8(" + field[8].GetPieceToken() + ") |");
        }

        public void MoveField(Player player, Player playertwo, int fieldToMove)
        {
            Field playermove = new Field(fieldToMove, player.GetPlayerToken());
            //::IMPLEMENT::Check if token is allready there.
            while (field[fieldToMove].GetToken() != null)
            {
                Console.WriteLine("Spot allready taken, choose a new spot");
                fieldToMove = Convert.ToInt32(Console.ReadLine());
            }
            field[fieldToMove] = playermove;
            string IsPieceTokenNull = field[0].GetPieceToken();
            Thread.Sleep(1000);
        }
        //::IMPLEMENT::Check for 3 on a row horizontal vertical diagonal.
        public bool CheckForWin()
        {
            //Figure out a way to check if fields contains Tokens before running this.
            if (true)
            {
//Vertical
                for (int i = 0; i < 3; i++)
                {
                    if (field[i].GetToken() == field[i + 3].GetToken() && field[i + 3].GetToken() == field[i + 6].GetToken())
                    {
                        Console.WriteLine("Its a win");
                        return true;
                    }
                }
//Horizontal
                for (int i = 0; i < 3; i++)
                {
                    if (field[i].GetToken() == field[i + 1].GetToken() && field[i + 1].GetToken() == field[i + 2].GetToken())
                    {
                        Console.WriteLine("Its a win");
                        return true;
                    }
                    i = i + 2;
                }
//Diagonal
                if (field[0].GetToken() == field[4].GetToken() && field[4].GetToken() == field[8].GetToken())
                {
                    Console.WriteLine("Its a win");
                    return true;
                }
                if (field[2].GetToken() == field[4].GetToken() && field[4].GetToken() == field[6].GetToken())
                {
                    Console.WriteLine("Its a win");
                    return true;
                }
            }
            return false;
        }
    }
}
