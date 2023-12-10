using System;
int EndlessCycl(int i){
    int num = Convert.ToInt32(Console.ReadLine());
    int x = num, count=0;
    while(x>0){
        x = x/10;
        count++;
    }
    if ((num%10+num/(10*count))%2 != 0){
        i++;
        return i;
    }else{
        return i;
    }
}
int i =0;
while(i == 0){
    if(EndlessCycl(i) == 1){
        i++;
    }
}