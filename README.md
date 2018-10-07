# KKParticleSystem
Homework task for Unity Academy. A simple particle system written in C#. The goal is to compare the performance differences using Object-oriented design and Data-oriented design.

10/7/2018 1:10 PM:
There is a working prototype based on Object-oriented design. The Particle System runs at 12 fps with 35000 particles. The biggest bottleneck is rendering. System.Drawaing.Graphics.FillEllipse() takes 70.25% of all the time. Should find a way on how to improve this issue before trying to migrate to Data-oriented design.

10/7/2018 1:27 PM:
Changed System.Drawaing.Graphics.FillEllipse() to System.Drawaing.Graphics.FillRectangle(). Now System.Drawaing.Graphics.FillRectangle() 44.83% of all the time and everything runs at around 10 fps with 55000 particles. Also, on high loads, rendering starts malfunctioning and not all of the particles are rendered on the screen. Currently, I cannot seem to find the cause of such behavior.
