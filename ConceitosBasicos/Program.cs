﻿// See https://aka.ms/new-console-template for more information

using ConceitosBasicos;

int num1 = 20;
int num2 = 11, result;

Somador soma;
soma = new Somador();

//Conversor conversor = new Conversor();

//altere a saída para que exiba:
//A soma dos números ____ + ___ é ____
result = soma.Soma(num1,num2);

Console.WriteLine($"A soma dos números {num1} + {num2} é {result}");
//altere a saída para que exiba:
//A medida ____ metros corresponde a ___ milimetros
double metros = 1.76;
Console.WriteLine("A medida {0} metros corresponde a {1}",metros,Conversor.MetrosMilimetros(1.76));