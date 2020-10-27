# Backend test

Welcome to Docplanner Group technical test

### Description

Welcome to Docplanner automated hospital. Ironically, by trying to make the healthcare more human we created a hospital which 
is fully ran by robots. Those robots are designed to handle different conditions and treatments people may have.

When a patient makes an appointment in our hospital, we request a robot that can handle their condition and allocate
it.

### Tasks

During the whole exercise we'll take into account the clarity of the code, reasoning of the solutions, and the coding practices the 
candidates have used. This exercise is meant to be done in pair/mob programming so please take your time to discuss the solution you 
want to implement before doing it.

#### Task 1 - Get a robot for a given condition

We have an endpoint that returns a robot able to treat a given condition. However this code was done by 
coding robot version 1 (KDR-1), which had some flaws, and we would like you to refactor it and improve it.

#### Task 2 - Enhanced robots

Engineering team has been able to create robots that can treat multiple conditions. In this task we should modify our 
solution so robots can be associated to multiple conditions. 

We divide now conditions in two: the ones that require surgery and the ones that don't, in case of requiring surgery 
we would also want to know the type of surgery required and the length of the recovery. In case of conditions that don't require
surgery we want to know if they can be treated with a psycologist.

#### Task 3 - External notifications

When finishing a treatment we're notificating the Engineering, Invoicing and Customer departments, but we have a request to 
notify the marketing department as well so they can post a picture of the patient on social media. This code was also created
by KDR-1 so a refactor that takes into account SOLID principles would also be appreciated.

#### Task 4 - Checking in users

To keep a record of humans that have been attended in our hospital, you have to create an endpoint that allows us to store the information
of the human (identified by the uuid in their implanted microchip), and the disease treated during the visit to the hospital.

### Attribution

© All rights reserved to Doctoralia Internet S.L.
