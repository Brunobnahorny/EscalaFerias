<template>
  <div>
    <Titulo titulo="Login" />
    <div class="content">
      <form action method="post">
        <label for="email">
          <span>
            Email
            <span class="required">*</span>
          </span>
          <input type="email" class="input-field" name="email" required value />
        </label>
        <label for="password">
          <span>
            Password
            <span class="required">*</span>
          </span>
          <input type="password" class="input-field" name="password" required value />
        </label>
        <button>Entrar</button>
      </form>
    </div>
  </div>
</template>

<script>
import Titulo from "../../components/_shared/_titulo";

export default {
  components: {
    Titulo
  }
};
</script>

<style scoped>
label {
  display: block;
  margin: 0px 0px 15px 0px;
}
label > span {
  width: 100px;
  font-weight: bold;
  float: left;
  padding-top: 8px;
  padding-right: 5px;
}
span.required {
  color: red;
}
.tel-number-field {
  width: 40px;
  text-align: center;
}
input.input-field {
  width: 48%;
}
input.input-field {
  box-sizing: border-box;
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  border: 1px solid #c2c2c2;
  box-shadow: 1px 1px 4px #ebebeb;
  -moz-box-shadow: 1px 1px 4px #ebebeb;
  -webkit-box-shadow: 1px 1px 4px #ebebeb;
  border-radius: 3px;
  -webkit-border-radius: 3px;
  -moz-border-radius: 3px;
  padding: 7px;
  outline: none;
}
.input-field:focus {
  border: 1px solid var(--cor-principal);
}
button {
  outline: none;
  position: absolute;
  left: calc(40px + 48%);
  border: none;
  padding: 8px 15px 8px 15px;
  background-color: var(--cor-clara);
  background-image: linear-gradient(
    45deg,
    var(--cor-secundaria),
    var(--cor-clara)
  );
  color: var(--cor-cinza);
  box-shadow: 1px 1px 4px black;
  border-radius: 3px;
}
button:hover {
  background: #ea7b00;
  color: #fff;
}
button:active {
  transition: 200ms;
  background-image: none;
  box-shadow: 0px 0px 0px;
}
</style>