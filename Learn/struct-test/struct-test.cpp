#include <stdio.h>

typedef struct{
	int var1;
	char var2;
}Struct;

Struct * _global;

void Fun(Struct * tmp) {
    printf("OK");
    //printf("%d", tmp->var1);
}

int main(){
    Struct * a;
    //Fun(a);
    //_global->var1 = 8;//无效操作
    Fun(_global);
}
