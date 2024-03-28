import express from "express";
import { insertCampus } from "../controller/CampusController.js"
import { insertEvento } from "../controller/EventoController.js";
import { EventoCampusModel } from "../controller/EventoCampusController.js";

const router = express.Router();

/**
 * @swagger
 * api/insert/campus:
 *   post:
 *     summary: Insertar un nuevo campus
 *     description: Inserta un nuevo campus en la base de datos.
 *     requestBody:
 *       required: true
 *       content:
 *         application/json:
 *           schema:
 *             type: object
 *             properties:
 *               id:
 *                 type: int
 *               name:
 *                 type: int
 *     responses:
 *       200:
 *         description: Campus insertado correctamente
 *       500:
 *         description: Error al insertar el campus
 */
router.post('/insert/campus', insertCampus);

router.post('/insert/evento', insertEvento);

router.post('/insert/evento/campus', EventoCampusModel);

export default router;