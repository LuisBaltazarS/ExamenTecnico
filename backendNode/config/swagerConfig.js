import swaggerJSDoc from 'swagger-jsdoc';

const options = {
  definition: {
    openapi: '3.0.0',
    info: {
      title: 'API de mi aplicación',
      version: '1.0.0',
      description: 'Documentación de la API de mi aplicación',
    },
    servers: [
      {
        url: 'http://localhost:4100/',
      },
    ],
  },
  apis: ['../routes/index.js'],
};

const swaggerSpec = swaggerJSDoc(options);

export default swaggerSpec;
