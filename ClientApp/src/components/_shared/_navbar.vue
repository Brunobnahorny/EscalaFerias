<template>
  <div>
    <nav>
      <ul>
        <div class="row">
          <li>
            <img alt="Vue logo" src="../../assets/logo.png" />
          </li>
        </div>
        <li>
          <p>EscalaFácil</p>
        </li>
        <li>
          <router-link  to="/" as="a">Home</router-link>
        </li>
        <li>
          <router-link to="/Login" as="a">Login</router-link>
        </li>
        <li>
          <router-link to="/Stores" as="a">Stores</router-link>
        </li>
      </ul>
    </nav>
  </div>
</template>

<script>
export default {
  components: {},
  data() {
    return {};
  },
  methods: {
    
  }
};
</script>

<style scoped>
nav {
  background-image: var(--cor-grad1);
  position: fixed;
  top: 0;
  width: 100%;
}
nav ul {
  list-style-type: none;
  margin: 0;
  padding: 0;
  overflow: hidden;
}
nav li {
  display: inline;
}
nav li a {
  display: inline-block;
  color: var(--cor-cinza3);
  padding: 8px 16px;
  text-decoration: none;
}
nav li a:hover {
  background-color: var(--cor-terciaria);
  color: white;
}
.active {
  background-color: var(--cor-terciaria);
  color: white;
}

nav li img {
  position: absolute;
  left: 16px;
  top: 8px;
  width: var(--size-Wlogo);
  z-index: 2;
}
nav li p {
  position: absolute;
  left: 10px;
  top: calc(var(--size-Wlogo) - 10px);
  z-index: 2;
  font-weight: bold;
  font-family: Verdana, Geneva, Tahoma, sans-serif;
  text-shadow: 2px 2px 5px var(--cor-terciaria);
  color: var(--cor-cinza3);
}
.row {
  display: inline-block;
  width: 116px;
}
</style>