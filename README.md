# KKParticleSystem
Homework task for Unity Academy. A simple particle system written in C#. The goal is to compare the performance differences using Object-oriented design and Data-oriented design.

10/7/2018 1:10 PM:
There is a working prototype based on Object-oriented design. The Particle System runs at 12 fps with 35000 particles. The biggest bottleneck is rendering. System.Drawaing.Graphics.FillEllipse() takes 70.25% of all the time. Should find a way on how to improve this issue before trying to migrate to Data-oriented design.

10/7/2018 1:27 PM:
Changed System.Drawaing.Graphics.FillEllipse() to System.Drawaing.Graphics.FillRectangle(). Now System.Drawaing.Graphics.FillRectangle() 44.83% of all the time and everything runs at around 10 fps with 55000 particles. Also, on high loads, rendering starts malfunctioning and not all of the particles are rendered on the screen. Currently, I cannot seem to find the cause of such behavior.

10/7/2018 2:05 PM:
Reworked the project to use Data-oriented design. The Particle System has a list of Particles. However, now each particle object only has an Integer ID. All the information is stored in Particle System class. It has arrays for positions, velocities, lifetimes, sizes and accelerations. Properties for each particle can be accessed via particle's ID. Also, there's a Queue of unused indexes. At first, we enqueue all the possible indexes to this Queue. During the runtime, when the particle is destroyed, the ID is Enqueued to this Queue. And when we need to create a new particle, we Dequeue the first available free ID from the Queue.

Sadly, I was not able to get any significant performance boost using the Data-oriented design as the whole project is still being bottlenecked by System.Drawaing.Graphics.FillRectangle() which uses 50.32% of all the time. It runs at around 13 fps with 55000 particles.

10/7/2018 2:47 PM:

Profiler analysis for OOD version:
![alt text](https://github.com/KasparasKralikas/KKParticleSystem/blob/master/OOD.png)

Profiler analysis for DOD version:
![alt text](https://github.com/KasparasKralikas/KKParticleSystem/blob/master/DOD.png)

To conclude:
The performance difference is not as big as I expected because the program is greatly bottlenecked by the rendering part - Windows Forms is not the best tool for such task. For better results I would consider redoing this project with C++ and a lightweight rendering library. However, I still learned a lot about data-oriented programming and the importance of efficient code for larger projects. On the other hand, I think that code readability and scalability is greatly impacted when data-oriented design is used instead of the classic object-oriented approach.
