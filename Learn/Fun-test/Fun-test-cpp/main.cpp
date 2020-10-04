#include "Fun.h"
#include <iostream>

int main() {
    Fun * a = new Fun();
    int b = a->Add(40, 50);
    int c = a->Sub(50, 40);
    return 0;
}