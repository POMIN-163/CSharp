#include "Fun.h"

int Fun::Add(int a, int b) {
    return a + b;
}
int Fun::Sub(int a, int b) {
    return a - b;
}

int Fun::Add_static(int a, int b) {
    return a + b;
}
int Fun::Sub_static(int a, int b) {
    return a - b;
}
int Class_test::GetAge(Class_test * a) {
    return a->age;
}