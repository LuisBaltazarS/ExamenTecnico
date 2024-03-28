import express from "express";
import router from "./routes/index.js";
import swaggerUi from 'swagger-ui-express';
import swaggerSpec from './config/swagerConfig.js';

const app = express();
const PORT = 4100; 

app.use(express.json());

app.use('/api-docs', swaggerUi.serve, swaggerUi.setup(swaggerSpec));

app.use('/api', router);

app.listen( PORT, () => {

    console.log(`Servidor escuchando en el puerto ${PORT}`);

});

