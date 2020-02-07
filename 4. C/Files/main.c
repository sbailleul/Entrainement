#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdarg.h>

int getFileSize(FILE *f);

typedef struct Player {

    char *name;
    int age;

}Player;


int main() {
    FILE *f;
    int fileSize = 0;
    char *bf;
    char *str;
    Player p;

    p.age=12;
    p.name=strcpy(malloc(sizeof(char)*(strlen("Thomas")+1)),"Thomas");


    if((f=fopen("test.txt","a+"))==NULL){
        return 0;
    }
    fileSize=getFileSize(f);
    bf=calloc(sizeof(char),(fileSize+1));
    str=calloc(sizeof(char),(fileSize+1));

    fscanf(f,"{\"%[^{}\"]}",bf);
    fscanf(f,"{\"%[^{}\"]}",str);



//    fread(bf,fileSize,sizeof(char),f);

    printf("bf : %s \n",bf);
    printf("str : %s \n",str);

    fclose(f);
    return 0;
}

int getFileSize(FILE *f){

    int size=0;
    char c;
    while(c=fgetc(f),c!=EOF){
        size++;
    }
    fseek(f,SEEK_SET,0);

    return size;
}

//int addPlayer(FILE *f,Player p){
//
//    fprintf(f,"{name:\"%s\",\"age\":%d",p.name,p.)
//
//}