# BlockDomains

## Introduction

A router has an in-memory collection B of M external domains which cannot be visited by local network user. There is a rule that if a domain is blocked, any its subdomains are blocked too.
For example, if domain adult.hb is blocked, the following hosts are blocked too: images.adult.hb, ringo.adult.hb, video.ringo.adult.hb.

Given a non-empty array A of N hosts, and B of M blocked domains, returns a sequence consisting of L integers where each integer represents an index of a host in input A array that can be visited by user.

## Solution

- Build a trie for blocked domains:
  - Given a blocked domain, reverse domain parts (sub.example.com -> com.example.sub) to build an efficient trie (parent node will be more common than child nodes)
- Given a domain, traversal the trie to check whether the domain is blocked or not

### Example Input
```
A[0] = unlock.microvirus.md
A[1] = visitwar.com
A[2] = visitwar.de
A[3] = fruonline.co.uk
A[4] = australia.open.com
A[5] = credit.card.us
```
```
B[0] = "microvirus.md",
B[1] = "visitwar.de",
B[2] = "piratebay.co.uk",
B[3] = "list.stolen.credit.card.us",
```
### Example Output
```
1, 3, 4, 5
```
## Author

- Dao Lam
