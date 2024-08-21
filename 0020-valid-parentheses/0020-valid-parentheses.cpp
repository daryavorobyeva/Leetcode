#include <iostream>
#include <stack>
using namespace std;

class Solution {
private:
    bool isOpen(const char c) {
        return ((c == '(') || (c == '{') || (c == '['));
    }

    bool correct(const char c1, const char c2) {
        return (((c1 == '(') && (c2 == ')')) || ((c1 == '{') && (c2 == '}')) || ((c1 == '[') && (c2 == ']')));
    }

public:
    bool isValid(string s) {
        stack<char> s1;
        for (const auto &elem: s) {
            if (isOpen(elem)) {
                s1.push(elem);
            } else if (!isOpen(elem)) {
                if (!s1.empty() && correct(s1.top(), elem)) {
                    s1.pop();
                } else {
                    return 0;
                }
            }
        }
        return s1.empty();
    }
};
