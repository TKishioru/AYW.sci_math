#include<stdio.h>
#include<conio.h>
#include<stdlib.h>

int main()
{   
    int principal,DC,money,year,month,ny,rm;
    float interest,total;
    char ans;
   
    do
    {
        system ("cls");
        //clrscr();
	    printf ("Welcome to interest calculator. [Fixed Deposits]");             
        printf ("\n\nEnter your principal : ");
        scanf("%d",&principal);
        printf ("Enter your year number : ");
        scanf("%d",&year);
        printf ("Fill interest per year : ");
        scanf ("%f",&interest);
   
        ny = 1;
        DC = principal;
        money = principal;
       
        while (ny <= year)
        {
            for(rm=1;rm<=12;rm++)
            {
                money = money + DC;
            }
       
            total = principal * (interest/100);
            ny = ny + 1;
        }
   
        printf ("\nprincipal : %d \n",principal);
        printf ("All Money : %d \n",money-principal);
        printf ("interest %.2f in %d year : %.2f",interest,year,total*year);
   
        printf ("\nAgain (Y/N)");
        scanf (" %c",&ans);

    }
    while ((ans == 'Y')||(ans == 'y'));
    printf("\nThank you");
       
    getch();
}



