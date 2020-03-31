<template>
  <div>
    <div>
      <h1>{{titulo}}</h1>
    </div>
    <button @click="voltar()">Voltar</button>
  </div>
</template>

<script>
export default {
  props: {
    titulo: {
      default: "Título"
    }
  },
  methods: {
    voltar() {
      this.$router.back();
    }
  }
};
</script>

<style scoped>
div {
  padding: 16px var(--size-Wlogo);
  height: 58px;
}
h1 {
  margin: 3vh;
  font-size: 4vw;
}
button {
  font-size: 1em;
  margin-top: 5px;
  outline: none;
  float: right;
  border: none;
  padding: 8px 15px 8px 15px;
  background-color: var(--cor-principal2);
  background-image: linear-gradient(
    45deg,
    var(--cor-principal2),
    var(--cor-clara)
  );
  color: white;
  box-shadow: 1px 1px 4px black;
  border-radius: 4px;
}
button:active {
  transition: 200ms;
  background-image: none;
  box-shadow: 0px 0px 0px;
}
</style>