#include <conio.h>
#include <iostream>
#include <math.h>

using namespace std;

int main()
{
   float num,soma=0,media;
   int ct=1;
   do
   {
      cout<<"\nDigite um numero real:";
      cin>>num;
      soma+=num;
      ct++;
   } 
   while (ct<=10); 
   media=soma/10;
   cout<<"\nSoma dos valores:"<<soma;  
   cout<<"\nMedia dos valores:"<<media;
   getch();	
}

