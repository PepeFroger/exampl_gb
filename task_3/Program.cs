﻿﻿using System;
Random rnd = new Random();
int N = 5;
int [] mas = new int [N];
for (int i=0; i<N;i++){
    mas[i] = rnd.Next(100,999);
    Console.Write($"{mas[i]}\t");
}
Console.WriteLine();
void ReverseArray(int[] mas){
    int t;
    for (int i=0;i<mas.Length/2;i++){
        t = mas[i];
        mas[i] = mas[mas.Length - i - 1];
        mas[mas.Length - i - 1] = t;
    }
    return;
    }
ReverseArray(mas);
for (int i=0;i<N;i++){
    Console.Write($"{mas[i]}\t");
}
