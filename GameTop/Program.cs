﻿using System;
using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
           var jogo = new jogoFODA(
               new Jogador1("Ronaldo "),
               new Jogador2());
           jogo.IniciarJogo();

        }
    }

}