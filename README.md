# Geo Service Core Containers Update

All modern Geo Service that is cross Linux Compatible will be built into a Kubernetes container onto this repository. 
-GDE Installation
-Geo Service Wrapper 
-Geo Service Web API
-Geo Service Batch Process

The purpose of this repository is to containerize Geo Service into an automated built docker container that will import GDE and setup GDE in order for Geo Web API to build into a containerized Linux pod.
The Batch process system will also build GDE from an remote image, build Geo Service Wrapper into a Azure batch process system. 


This design architecture will use the modern AKS (Kubernetes Cluster), potentially decouple platform into multiple microservices and scale the application into the modern cloud environment 
while centralizing project repository into a single git repository.
