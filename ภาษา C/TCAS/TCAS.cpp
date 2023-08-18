#include<stdio.h> 
#include<conio.h>

int main()
{
    float GPAX, onet, gat, patsci, pateng, admission, uni;
    
    printf("Welcome to TCAS Round 3 :: Faculty of Engineering\n");
    printf("The lowest score of the university you want to enter. : ");
    scanf("%f",&uni);
    printf("Your GPAX (6 Term) : ");
    scanf("%f",&GPAX);
    printf("Score O-net (All Subject) : ");
    scanf("%f",&onet);
    printf("Score Gat (300) : ");
    scanf("%f",&gat);
    printf("Score Pat 2 (300) : ");
    scanf("%f",&patsci);
    printf("Score Pat 3 (300) : ");
    scanf("%f",&pateng);
    admission = (GPAX * 1500) + (onet * 18) + (gat * 15) + (patsci * 15) + (pateng * 20);
    if (admission >= uni)
    {
        printf("Congratulations, you can join this university.\n");
    }
    else
    {
        printf("SHOW YOUR SCORE : %.2f\n",admission);
        admission = uni - admission;
        printf("%.2f more points\n",admission);
        printf("Sorry you have to try harder than this.\n");
    }
	getch();
}
