# C-sharp.Exercises (3)

In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
and down-voting. You should not give the ability to set the Vote property from the outside,
because otherwise, you may accidentally change the votes of a class to 0 or to a random
number. And this is how we create bugs in our programs. The class should always protect its
state and hide its implementation detail.  
 
Educational tip: The aim of this exercise is to help you understand that classes should
encapsulate data AND behaviour around that data. Many developers (even those with years of
experience) tend to create classes that are purely data containers, and other classes that are
purely behaviour (methods) providers. This is not object-oriented programming. This is
procedural programming. Such programs are very fragile. Making a change breaks many parts
of the code.
