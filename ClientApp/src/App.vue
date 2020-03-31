<template>
  <div id="app">
    <Navbar/>


    <Footer/>
    <router-view :key="$route.fullpath"></router-view>
  </div>
</template>

<script>
import Navbar from './components/_shared/_navbar'
import Footer from './components/_shared/_footer'


export default {
  name: 'App',
  components: {
    Navbar,
    Footer
  }  
}
</script>

<style>
body {
  --cor-principal: #856c8b;
  --cor-principal2: #015668;
  --cor-secundaria: #d4ebd0;
  --cor-terciaria: #a4c5c6;
  --cor-clara: #ffeb99;
  --cor-cinza1: #706c61;
  --cor-cinza2: #5b5656;
  --cor-cinza3: #2c3e50;
  --cor-grad1: linear-gradient(to right, #d4ebd0, #a4c5c6);
  --size-Wlogo: 84px;
  margin: 0;
  padding: 0;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  font-size: 18px;
  font-family: Avenir, Helvetica, Arial, sans-serif;
  color: var(--cor-cinza3);
}
.content {
  padding: 64px 24px;
}
.content p {
  text-align: justify;
}
.clickable {
  cursor: pointer;
}
button {
  cursor: pointer;
}
</style>
