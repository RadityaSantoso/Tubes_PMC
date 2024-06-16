//FOR TESTING, LEAVE BLANK

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>
#define MAX 50

void first_date_format(char* str){
    if(strcmp(str, "Januari")==0){
        strcpy(str,"01");
    }
    else if(strcmp(str, "Februari")==0){
        strcpy(str,"02");
    }
    else if(strcmp(str, "Maret")==0){
        strcpy(str,"03");
    }
    else if(strcmp(str, "April")==0){
        strcpy(str,"04");
    }
    else if(strcmp(str, "Mei")==0){
        strcpy(str,"05");
    }
    else if(strcmp(str, "Juni")==0){
        strcpy(str,"06");
    }
    else if(strcmp(str, "Juli")==0){
        strcpy(str,"07");
    }
    else if(strcmp(str, "Agustus")==0){
        strcpy(str,"08");
    }
    else if(strcmp(str, "September")==0){
        strcpy(str,"09");
    }
    else if(strcmp(str, "Oktober")==0){
        strcpy(str,"10");
    }
    else if(strcmp(str, "November")==0){
        strcpy(str,"11");
    }
    else if(strcmp(str, "Desember")==0){
        strcpy(str,"12");
    }

}

void second_date_format(char* str){
    if(strcmp(str, "Jan")==0){
        strcpy(str,"01");
    }
    else if(strcmp(str, "Feb")==0){
        strcpy(str,"02");
    }
    else if(strcmp(str, "Mar")==0){
        strcpy(str,"03");
    }
    else if(strcmp(str, "Apr")==0){
        strcpy(str,"04");
    }
    else if(strcmp(str, "Mei")==0){
        strcpy(str,"05");
    }
    else if(strcmp(str, "Jun")==0){
        strcpy(str,"06");
    }
    else if(strcmp(str, "Jul")==0){
        strcpy(str,"07");
    }
    else if(strcmp(str, "Agu")==0){
        strcpy(str,"08");
    }
    else if(strcmp(str, "Sep")==0){
        strcpy(str,"09");
    }
    else if(strcmp(str, "Okt")==0){
        strcpy(str,"10");
    }
    else if(strcmp(str, "Nov")==0){
        strcpy(str,"11");
    }
    else if(strcmp(str, "Des")==0){
        strcpy(str,"12");
    }
}

char* format_date(const char* str){
    int len = strlen(str);

    //checker if format 1 or 2 {1 is spaces, 2 is -'s}, default 2
    char delimiter;
    char* checker=strchr(str, '-');
    if(checker==NULL){
        delimiter=' ';
    }
    else{
        delimiter='-';
    }

    //splitting
    //char* temp = strchr(str,delimiter);
    char* temp = strchr(str, delimiter);
    char day[5];
    int starting_index=0;
    for(int i=starting_index; i<temp-str;i++){
        day[i-starting_index]=str[i];
    }
    day[temp-str-starting_index]='\0';

    char month[MAX];
    starting_index=temp-str+1;
    temp=strchr(temp+1,delimiter);
    for(int i=starting_index; i<temp-str;i++){
        month[i-starting_index]=str[i];
    }
    month[temp-str-starting_index]='\0';

    char year[5];
    starting_index=temp-str+1;
    for(int i=starting_index; i<len;i++){
        year[i-starting_index]=str[i];
    }
    year[len-starting_index]='\0';


    char* output=malloc(sizeof(MAX));
    for(int i=0; i<strlen(year);i++){
        output[i]=year[i];
    }
    if(delimiter=='-'){
        second_date_format(month);
    }
    else{
        first_date_format(month);
    }
    output[strlen(year)]=month[0];
    output[strlen(year)+1]=month[1];
    if(strlen(day)==1){
        output[2+strlen(year)]='0';
        output[3+strlen(year)]=day[0];
    }
    else{
        output[2+strlen(year)]=day[0];
        output[3+strlen(year)]=day[1];
    }
    output[4+strlen(year)]='\0';
    return output;
}

int main(){
    char input_string[50],formatted_date[50];
    fgets(input_string,MAX,stdin);
    input_string[strlen(input_string)-1]='\0';
    strcpy(formatted_date,format_date(input_string));
    printf("%s", formatted_date);
}