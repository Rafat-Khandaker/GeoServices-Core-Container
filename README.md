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

## How To Run Container  
 ### Pre-Requisites:  
  -Download and install Docker Desktop  
  -Switch to Linux mode  
  
###  Instructions:  
  -Download project    
  -Open Command Line prompt and CD (change into GeoServices-Core-Container Directory)   

 ### Run Commands:
  
  docker build -f Web-API.Dockerfile -t geoservicescorewebapi:dev .  
  docker run -d -p 8082:8081 geoservicescorewebapi:dev    

  ### Navigate into SSL port:   
  https://localhost:8082    
  
  ### Use calling convention:   
  https://localhost:8082/Function_{function_version}?key={api_key_value}&parameter1={param_1}&parameter2={param_2}

 
