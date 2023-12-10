﻿using System;
Random rnd = new Random();
int N = 5;
int RandMas(){
    int mas_i;
    mas_i= rnd.Next(100,999);
    return mas_i;
}
int count = 0;
int [] mas = new int [N];
for (int i=0; i<N;i++){
    mas[i] = RandMas();
    Console.Write($"{mas[i]}\t");
    if(mas[i]%2==0){
        count++;
    }
}
Console.WriteLine($"\n{count}");

