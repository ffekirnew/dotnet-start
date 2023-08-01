# Api Docs

## Table of Contents

## Auth
### Register

```js
POST {{host}}/api/auth/register
```

#### Request Body
```json
{
    "firstName": "string",
    "lastName": "string",
    "email": "string",
    "password": "string",
}
```

#### Response Body
```json
{
    "id": "string",
    "firstName": "string",
    "lastName": "string",
    "email": "string",
    "token": "string"
}
```

### Login

```js
POST {{host}}/api/auth/login
```

#### Request Body
```json
{
    "email": "string",
    "password": "string",
}
```

#### Response Body
```json
{
    "id": "string",
    "firstName": "string",
    "lastName": "string",
    "email": "string",
    "token": "string"
}
```