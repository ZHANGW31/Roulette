# Roulette

Roulette simulator project for class. 

This program models a roulette wheel. 

**Description**

The ball can fall randomly into one of 38 different bins. 

This program will calculate all the winning bets according to the bin the ball falls into.

As an output, this program will print the winning bin to standard output, together with all the winning bets.

For example, if the ball comes to rest in square 26, the winning split bets could be 23/26, 26/27, 26/29 and 25/26, while the winning
Corner bets could be 22/23/25/26, 23/24/26/27, 25/26/28/29 and 26/27/29/30

**How the application works**


Upon launch program first randomly generates a number between 1 and 38

The number is then evaluated against the bet methods to compute and determine what are the winning cases.

The resulting possible winning cases are then displayed to the console.
