//FOR TESTING, LEAVE BLANK

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>
#define MAX 50



int main(){
    char input_string[50],formatted_date[50];
    fgets(input_string,MAX,stdin);
    input_string[strlen(input_string)-1]='\0';
    strcpy(formatted_date,format_date(input_string));
    printf("%s", formatted_date);
}