<p align="center">
 <img width="200" src="https://cdn.iconscout.com/icon/premium/png-256-thumb/api-integration-3919433-3246625.png" alt="API">
</p>

# EDCS API Integration 
The aim of this project is to highlight the smooth integration of backend APIs with our current enrollment application, directing data flow seamlessly to our EDCS application endpoint.

### How it works:
```
This application serves as a demonstration of how to integrate our Enrollment Application with our EDCS using C#. However, you have the flexibility to use other programming languages according to your preference.

1. Authenticate with valid user credentials.
2. Upon successful authentication, the application will make a request to our EDCS login endpoint, which will return user credentials along with an access token.
3. Verify if the token property has a value.
4. Set the obtained token as the Authorization header.
5. Make a request to the PR Upload endpoint (/promotional-reports/load-pr) and configure your payload accordingly.
6. The application will handle the response based on the actual backend validation.
7. In case of any issues, ensure to double-check your implementation for any errors or omissions.
````

##### Note: For further information, we recommend referring to our API Integration Manual.    
For detailed explanation on how things work, check out [C#](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/).
