This program demostrates collision and pre-image hash attacks using truncated digests of SHA-1.
If no text is entered, pressing "Collide!" will initiate a collision attack in which the program
generates strings of a random length between 60 and 100 consisting of random ASCII characters
from the visible range and stores their truncated digests. This process continues until the
truncated digest of a newly-generated string matches a remembered digest.
If a string is entered, pressing "Collide!" will begin a pre-image attack in which the program
will compare the truncated digests of randomly generated strings to the truncated digest of the
given string.
In both cases, the program will stop if no match has been found after two minutes.
The length to which the digests are truncated is hard-coded in both attacks.