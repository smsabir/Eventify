import { observer } from "mobx-react-lite";
import { Outlet, useLocation } from "react-router-dom";
import { Container } from "semantic-ui-react";
import HomePage from "../../features/home/HomePage";
import Navbar from "./Navbar";

function App() {
  const location = useLocation();

  return (
    <>
      {location.pathname === "/" ? (
        <HomePage />
      ) : (
        <>
          <Navbar />
          <Container style={{ marginTop: "7em" }}>
            <Outlet />
          </Container>
        </>
      )}
    </>
  );
}

export default observer(App);
