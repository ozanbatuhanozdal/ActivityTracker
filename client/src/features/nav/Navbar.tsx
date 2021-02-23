import React from "react";
import { Button, Menu } from "semantic-ui-react";

interface IProps {
  openCreateForm: () => void;
}

export const Navbar: React.FC<IProps> = ({ openCreateForm }) => {
  return (
    <Menu fixed="top" inverted>
      <Menu.Item header>
        <img src="/assets/logo.png" alt="logo" style={{ marginRight: 10 }} />
        Reactivities
      </Menu.Item>
      <Menu.Item name="Activities" />
      <Menu.Item name="friends" />
      <Menu.Item>
        <Button name="createActivity" onClick={openCreateForm} positive content='Create Activity'/>
      </Menu.Item>
    </Menu>
  );
};
