import math
print('Enter a grid.txt file containing a square maze at the same directory as \nthe maze2.py '\
      'file. The starting point should be an S, the ending point \nshould be a G, '\
      'the walls should be X and the blank space should be _, \notherwise the maze '\
      'pathfinder won\'t work.')
with open("grid.txt", "r") as grid: #opening and saving the file
      temp_grid=grid.read()
print('This is the maze:')
print(temp_grid)
temp_grid = temp_grid.replace('\n', '') #removing the line breaks
rows = int(math.sqrt(len(temp_grid)))  #since it is a square maze, the rows are the sqrt of all the maze elements
maze = []
for i in range(rows):
        maze.insert(0, []) #create nested list, so as to represent columns
b = 0
for m in range(rows):
        for n in range(rows):   #transfering from the string to the nested list
                maze[m].insert(n, temp_grid[b])
                b = b + 1
maze.insert(0, []) #inserting a top and a bottom line to use as walls of the maze
maze.append([])
for k in range(len(maze)-2): #inserting walls at the top and bottom edges of the maze
	maze[0].append('X')
	maze[-1].append('X')
for l in range(len(maze)):  #inserting walls at the left and right edges of the maze
	maze[l].insert(0, 'X')
	maze[l].append('X')
for x in range(len(maze)):   #finding and saving as (row, col) the starting point of the maze
    for y in range(len(maze)):
        if maze[x][y]=='S':
            (row, col)=(x, y)
print('Starting at: (',row,',',col,')')
maze[row][col] = 'V'
a = 1
while a!=0:
    if maze[row][col+1] == 'G':
        print('Found the ending point at: (',row,',',col+1,')')
        a = 0
    elif maze[row+1][col] == 'G':
        print('Found the ending point at: (',row+1,',',col,')')
        a = 0
    elif maze[row][col-1] == 'G':
        print('Found the ending point at: (',row,',',col-1,')')
        a = 0
    elif maze[row-1][col] == 'G':
        print('Found the ending point at: (',row-1,',',col,')')
        a = 0
    elif maze[row][col+1] == 'X':
        if maze[row+1][col] == 'X':
            if maze[row][col-1] == 'X':
                if maze[row-1][col] == 'X':
                    print('There is no way to the ending point')
                    a = 0
                elif maze[row-1][col] == '_':
                    print('Actor at: (',row-1,',',col,')')
                    maze[row-1][col] = 'V'
                    (row, col) = (row-1, col)
                elif maze[row-1][col] == 'V':
                    print('Actor revisiting: (',row-1,',',col,')')
                    maze[row-1][col] = 'X'
                    (row, col) = (row-1, col)
            elif maze[row][col-1] == '_':
                print('Actor at: (',row,',',col-1,')')
                maze[row][col-1] = 'V'
                (row, col) = (row, col-1)
            elif maze[row][col-1] == 'V':
                print('Actor revisiting: (',row,',',col-1,')')
                maze[row][col-1] = 'X'
                (row, col) = (row, col-1)
        elif maze[row+1][col] == '_':
            print('Actor at: (',row+1,',',col,')')
            maze[row+1][col] = 'V'
            (row, col) = (row+1, col)
        elif maze[row+1][col] == 'V':
            print('Actor revisiting: (',row+1,',',col,')')
            maze[row+1][col] = 'X'
            (row, col) = (row+1, col)
    elif maze[row][col+1] == '_':
        print('Actor at: (',row,',',col+1,')')
        maze[row][col+1] = 'V'
        (row, col) = (row, col+1)
    elif maze[row][col+1] == 'V':
        print('Actor revisiting: (',row,',',col+1,')')
        maze[row][col+1] = 'X'
        (row, col) = (row, col+1)
