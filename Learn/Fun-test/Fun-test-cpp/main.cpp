#include "Fun.h"
#include <iostream>

int main() {
    Fun * a = new Fun();
    int b = a->Add(40, 50);
    int c = a->Sub(50, 40);
    // Fun::Add(40, 50);
    // 这种写法会报错
    Fun::Add_static(40, 50);
    // 这种写法不会报错 (C++中非静态方法实例和类都能使用,但静态方法只能类调用)
    int b_s = a->Add_static(40, 50);
    int c_s = a->Sub_static(50, 40);// 实例调用静态方法
    printf("result 1:%d\nresult 2:%d\n", b, c);
    printf("result 1_s:%d\nresult 2_s:%d\n", b_s, c_s);

    Class_test * Stu1 = new Class_test(19, "pomin");
    printf(" age:%d\n name:%s\n", Class_test::GetAge(Stu1), Stu1->name);
    return 0;
}