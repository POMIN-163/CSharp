class Fun
{
public:
    int Add(int a, int b);
    int Sub(int a, int b);
    static int Add_static(int a, int b);
    static int Sub_static(int a, int b);
};
class Class_test
{
public:
    const char* name;
    // 构造函数
    Class_test(int age, const char* name) {
        this->age = age;
        this->name = name;
    }
    // 访问私有成员方法
    static int GetAge(Class_test * a);
private:
    int age;
};
