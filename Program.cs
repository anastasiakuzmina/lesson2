﻿
//**************************************************************************************************************************
//************Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.********
//**************************************************************************************************************************

/*
void Num2 (int number)
    {
    number=(number/10)%10;
    Console.Write($"Второе число: {number}");
    }

Console.Write("Введи трёхзначное число: ");

try 
 {
   int x = int.Parse(Console.ReadLine());
   Num2(x);
 }
 catch 
 {
    Console.Write("Необходимо вводить только цифры ");
 }
*/

//**************************************************************************************************************************
//************ Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.********
//**************************************************************************************************************************

/*
Console.Write("Введи число: ");
try 
 {
    int number = int.Parse(Console.ReadLine());
    if  (number/100 == 0)
    Console.Write("В веденном числе третьей цифры нет");
    else 
     {
      int tmp = number;
      while (tmp >= 100) 
      {
        number=tmp%10;
        tmp = tmp/10;
      }
      Console.Write($"третья цифра: {number}");  
     }     
 }
 catch
 {
    Console.Write("Необходимо вводить только цифры ");
 }

 */


//************************************************************************************************************************************
 //*** Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. ***
//************************************************************************************************************************************

/*
 Console.Write("Введи число: ");
 try 
 {
    int number = int.Parse(Console.ReadLine());
    if (number > 7 | number < 1)  Console.Write("Необходимо вводить только цифры от 1 до 7 ");
    else 
        {
            if (number > 5) Console.Write("Да");
            else Console.Write("Нет");
        }
 }     
 
 catch
 {
    Console.Write("Необходимо вводить только цифры от 1 до 7");
 }
 */