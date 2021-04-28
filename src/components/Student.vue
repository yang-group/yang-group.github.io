<template>
  <div>
    <v-card class="mx-auto" max-width="400">
      <v-img class="white--text align-end" height="250px" :src="stu.photo">
        <v-card-title> {{ stu.name }} </v-card-title>
      </v-img>

      <v-card-subtitle class="pb-0">
        <p>Year: {{ stu.year }}</p>
        <p>
          <i v-show="stu.email != null" class="mr-2">
            <v-tooltip bottom>
              <template v-slot:activator="{ on, attrs }">
                <v-icon color="green lighten-1" v-bind="attrs" v-on="on">
                  mdi-email
                </v-icon>
              </template>
              <span>{{ stu.email }}</span>
            </v-tooltip>
          </i>
          <i v-show="stu.github != null">
            <v-tooltip bottom>
              <template v-slot:activator="{ on, attrs }">
                <v-icon color="black" v-bind="attrs" v-on="on">
                  mdi-github
                </v-icon>
              </template>
              <span>{{ stu.github }}</span>
            </v-tooltip>
          </i>
        </p>
      </v-card-subtitle>

      <v-card-text class="text--primary">
        <v-chip-group column mandatory>
          <v-chip
            small
            outlined
            color="success"
            text-color="green lighten-1"
            v-for="i in stu.inerest"
            :key="i"
          >
            {{ i }}
          </v-chip>
        </v-chip-group>
      </v-card-text>
    </v-card>
  </div>
</template>

<script>
export default {
  props: {
    stu: {
      type: Object
    }
  }
}
</script>
