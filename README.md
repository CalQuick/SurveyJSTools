# HappyGPTools
Tools for manipulating JSON data required for web app optimisation

Some of the work required inputing logic and data onto a web app. The web app saved its data in JSON format.
This app is a collection of small tools to create some of that JSON data from scratch so it can be copied into the code quickly, or alternatively,
to take some of that JSON data, deserialize it, then convert it and reserialize it so it can be copied back into the web app.

This was my first project using CSharp - I wanted to learn a pure OOD language, and really enjoyed the challenge of explicit declaration.

Some of the things I learnt from this project include:
  - OOD
  - Sending data to and from different windows forms
  - Using Interfaces
  
 I spent a lot of time thinking about how best to design this program so that it can be added to / changed. Initially I thought I could use the strategy pattern to swap out algorithms during runtime. I then also used inheritance and interfaces to do this.
 I then decided to refactor without all this implemented because the small program became too complicated. "YAGN!"
 
 In the end I settled for 2 algorithms - one to process questions into questions and also panels. This allowed for code reuse because panels included questions.
 The second algorithm involved taking in serialised JSON data, converting into from one model to another and then serialising it back up.
