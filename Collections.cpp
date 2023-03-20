#include<bits/stdc++.h>

using namespace std;

int main(){

int arr[5] = {1, 2, 3, 4, 5};  // initializing an array of integers with 5 elements
cout << arr[0];                // accessing the first element of the array (output: 1)

vector<int> v = {1, 2, 3, 4, 5};  // initializing a vector of integers with 5 elements
v.push_back(6);                   // adding a new element to the end of the vector
cout << v[5];                     // accessing the last element of the vector (output: 6)

list<int> l = {1, 2, 3, 4, 5};   // initializing a list of integers with 5 elements
l.push_back(6);                  // adding a new element to the end of the list
l.push_front(0);                 // adding a new element to the front of the list
cout << l.front() << " " << l.back();  // accessing the first and last elements of the list (output: 0 6)
	
stack<string> stack;
stack.push("Alice");
stack.push("Bob");
stack.push("Charlie");
while (!stack.empty()) {
string name = stack.top();
stack.pop();
cout << name << endl;
	
queue<int> queue;
queue.push(1);
queue.push(2);
queue.push(3);
while (!queue.empty()) {
int number = queue.front();
queue.pop();
cout << number << endl;

set<int> s = {3, 1, 4, 1, 5, 9, 2};  // initializing a set of integers with 5 elements
s.insert(6);                        // adding a new element to the set
s.erase(4);                         // removing an element from the set
cout << s.count(9);                 // checking if an element exists in the set (output: 1)

map<string, int> m;                // initializing an empty map with string keys and integer values
m["apple"] = 5;                    // adding a new key-value pair to the map
m["banana"] = 2;
m["cherry"] = 7;
cout << m["banana"];               // accessing the value of a key in the map (output: 2)

	return 0;
}
