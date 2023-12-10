﻿using System;
Random rnd = new Random();
int N = 5;
int count;
int [] mas = new int [N];
for (int i=0; i<N;i++){
    mas[i] = rnd.Next(100,999);
    Console.Write($"{mas[i]}\t");
}
Console.WriteLine();
int CountEven(int [] mas){
    int count = 0;
    for(int i=0;i<N;i++){
        if(mas[i]%2==0){
            count++;
        }
    }
    return count;
}
count = CountEven(mas);
Console.Write(count);