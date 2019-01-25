# Gnome Sort 
Gnome sort Algorithm Implementation in c# + pseudocode 

# History
Gnome sort is a sorting algorithm originally proposed by iranian computer scientist Hamid Sarbazi-Azad. The Sort was first called stupid sort then later described by Dick Grune and named as gnome sort.
 
# Description
Gnome Sort is based on the technique used by the standard Dutch Garden Gnome
Here is how a garden gnome sorts a line of flower pots. 
Basically, he looks at the flower pot next to him and the previous one; if they are in the right order he steps one pot forward, otherwise, he swaps them and steps one pot backward. 
Boundary conditions: if there is no previous pot, he steps forwards; if there is no pot next to him, he is done.

# Pseudocode
procedure gnomeSort(a[]):     
pos := 0      
while pos < length(a):      
   if (pos == 0 or a[pos] >= a[pos-1]):      
       pos := pos + 1      
    else:     
        swap a[pos] and a[pos-1]      
        pos := pos - 1      
            
# Time Complexity
Worst complexity: n^2      
Average complexity: n^2      
Best complexity: n        
Space complexity: 1      
Method: Exchanging        
Stable: Yes      

# Group members
Waqar (17B-102-SE-B)      
Taha (17B-099-SE-B)   
Faiz (17B-090-SE-B)
