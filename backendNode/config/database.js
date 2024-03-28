import { Sequelize } from "sequelize";

const connection = new Sequelize( 'eventos', 'postgres', 'bluis', {

    host: 'localhost',
    port: '5432',
    dialect: 'postgres'

});

export default connection;