# Todo List Application

This is a simple console-based Todo List application built in C#. It allows users to manage a list of tasks interactively. The program presents a menu where users can perform various actions such as viewing, adding, or removing tasks from the list.

## Features

1. **[S]ee all todos**: Displays the current list of todo items. If there are no items, it will notify the user that the list is empty.
2. **[A]dd todo**: Prompts the user to enter a new todo item and adds it to the list. If the item already exists in the list, it notifies the user that it’s a duplicate.
3. **[R]emove todo**: Displays the current todo list with numbered indices and allows the user to select an item by index to remove it from the list.
4. **[E]xit**: Exits the program.

## Limitations

- **No persistence**: The todo list is stored only in memory while the program is running. When the program is exited, the list is lost. If you restart the program, the list will be empty.

## How to Run

1. Clone the repository to your local machine.
2. Open a terminal and navigate to the project directory.
3. Run the application using `dotnet run`.
4. Follow the prompts in the console to interact with the todo list.

## Program Output

```
Hello

What do you want to do?
[S]ee all todos
[A]dd todo
[R]emove todo
[E]xit
s

Todo list is currently empty.

What do you want to do?
[S]ee all todos
[A]dd todo
[R]emove todo
[E]xit
r

Your todo list is currently empty.

What do you want to do?
[S]ee all todos
[A]dd todo
[R]emove todo
[E]xit
x

Invalid option.

What do you want to do?
[S]ee all todos
[A]dd todo
[R]emove todo
[E]xit
a

Enter todo description:
Walk the cat

Added: Walk the cat

What do you want to do?
[S]ee all todos
[A]dd todo
[R]emove todo
[E]xit
a

Enter todo description:
Walk the cat

'Walk the cat' is already on your todo list.

What do you want to do?
[S]ee all todos
[A]dd todo
[R]emove todo
[E]xit
a

Enter todo description:
Clean litterbox

Added: Clean litterbox

What do you want to do?
[S]ee all todos
[A]dd todo
[R]emove todo
[E]xit
s

Your Current Todo List:
1. Walk the cat
2. Clean litterbox

What do you want to do?
[S]ee all todos
[A]dd todo
[R]emove todo
[E]xit
r

Your Current Todo List:
1. Walk the cat
2. Clean litterbox

Select the index of the todo you want to remove:
0

Invalid input. No items removed.

What do you want to do?
[S]ee all todos
[A]dd todo
[R]emove todo
[E]xit
r

Your Current Todo List:
1. Walk the cat
2. Clean litterbox

Select the index of the todo you want to remove:
1

Removed: 'Walk the cat'

What do you want to do?
[S]ee all todos
[A]dd todo
[R]emove todo
[E]xit
s

Your Current Todo List:
1. Clean litterbox

What do you want to do?
[S]ee all todos
[A]dd todo
[R]emove todo
[E]xit
e

Have a nice day!~
```
