import Form from "./components/Form";
import { getTipoEvento } from "./utils/ApiNET";

async function fetchData() {
  
  const { tipoEvento } = await getTipoEvento();

  return { tipoEvento }

}

export default async function Home() {

  const data = await fetchData();

  return (
    <Form data={ data }></Form>
  );
}

