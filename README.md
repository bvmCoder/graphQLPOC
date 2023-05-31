# Introduction 

* Step 1 : Set the starup project as Presentation
* Step 2 : Accept the creation of local certs (applicable in the case of first run only)

See screenshot
[GraphQL Playground](https://dev.azure.com/AlterDomusGlobal/45fffc53-a7ba-4dac-81a4-0f9f97d5e0e8/_apis/git/repositories/1c0e6c11-d9fb-4bcb-87ec-1c0fcc0a34b7/items?path=/DocumentAPI.GraphApi/docs/graphql-playground.png&versionDescriptor%5BversionOptions%5D=0&versionDescriptor%5BversionType%5D=0&versionDescriptor%5Bversion%5D=main&resolveLfs=true&%24format=octetStream&api-version=5.0)

* Step 3: In the graphQL editor enter the following.


**Simple query**

*Get all the movies list*

```json
{
  movies
  {
    id,
    title
  }
}
```

**Complex query**

*Bring me a list of who has reviewed what?*

```json
{
  authors
  {
    firstName,
    lastName,
    reviews
    {
      id,
      stars,
      movie
      {
       	title 
      }
    }
  }
}
```


```
13:12:26.898 -05:00 [Information] [Serilog.AspNetCore.RequestLoggingMiddleware] HTTP "POST" "/graphql" responded 200 in 1.4916 ms
13:12:27.072 -05:00 [Information] [Serilog.AspNetCore.RequestLoggingMiddleware] HTTP "POST" "/graphql" responded 200 in 1551.2920 ms
13:12:28.913 -05:00 [Information] [Serilog.AspNetCore.RequestLoggingMiddleware] HTTP "POST" "/graphql" responded 200 in 1.3683 ms
13:12:30.926 -05:00 [Information] [Serilog.AspNetCore.RequestLoggingMiddleware] HTTP "POST" "/graphql" responded 200 in 2.1045 ms
13:12:32.939 -05:00 [Information] [Serilog.AspNetCore.RequestLoggingMiddleware] HTTP "POST" "/graphql" responded 200 in 1.6899 ms
13:12:34.950 -05:00 [Information] [Serilog.AspNetCore.RequestLoggingMiddleware] HTTP "POST" "/graphql" responded 200 in 1.4581 ms
13:12:36.965 -05:00 [Information] [Serilog.AspNetCore.RequestLoggingMiddleware] HTTP "POST" "/graphql" responded 200 in 2.3452 ms
13:12:38.611 -05:00 [Information] [Serilog.AspNetCore.RequestLoggingMiddleware] HTTP "POST" "/graphql" responded 200 in 1.6165 ms
13:12:38.980 -05:00 [Information] [Serilog.AspNetCore.RequestLoggingMiddleware] HTTP "POST" "/graphql" responded 200 in 1.4566 ms
13:12:40.989 -05:00 [Information] [Serilog.AspNetCore.RequestLoggingMiddleware] HTTP "POST" "/graphql" responded 200 in 1.4298 ms
13:12:43.000 -05:00 [Information] [Serilog.AspNetCore.RequestLoggingMiddleware] HTTP "POST" "/graphql" responded 200 in 1.4641 ms
13:12:45.011 -05:00 [Information] [Serilog.AspNetCore.RequestLoggingMiddleware] HTTP "POST" "/graphql" responded 200 in 1.7365 ms
13:12:47.027 -05:00 [Information] [Serilog.AspNetCore.RequestLoggingMiddleware] HTTP "POST" "/graphql" responded 200 in 1.3318 ms
```