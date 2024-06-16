//FOR TESTING, LEAVE BLANK

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>


int main(){
    char input_string[50];
    scanf("%s",input_string);
    char* temp = strchr(input_string,'-');
    printf("%d\n", temp-input_string);
    char temp_string1[4];
    int starting_index=0;
    for(int i=starting_index; i<temp-input_string;i++){
        temp_string1[i-starting_index]=input_string[i];
    }
    char temp_string2[4];
    starting_index=temp-input_string+1;
    temp=strchr(temp+1,'-');
    for(int i=starting_index; i<temp-input_string;i++){
        temp_string2[i-starting_index]=input_string[i];
    }
    starting_index=temp-input_string+1;
    char temp_string3[4];
    for(int i=starting_index; i<strlen(input_string);i++){
        temp_string3[i-starting_index]=input_string[i];
    }
}